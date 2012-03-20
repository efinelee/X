:: 自动编译X组件，并更新到DLL中去
:: 1，更新所有源码Src
:: 2，更新DLL
:: 3，编译所有组件
:: 4，拷贝DLL
:: 5，提交DLL更新
:: 6，打包Src和DLL到FTP

::@echo off
::cls
setlocal enabledelayedexpansion
title 自动编译

:: 1，更新所有源码Src
:: 2，更新DLL
:: 保存当前目录，并切换目录
pushd ..
set svn=https://svn.nnhy.org/svn/X/trunk
:: do else 等关键字前后都应该预留空格
for %%i in (Src DLL) do (
	svn info %svn%/%%i
	svn update %%i
)
:: 恢复目录
popd

:: 3，编译所有组件
::"D:\MS\Microsoft Visual Studio 10.0\Common7\IDE\devenv.exe" X组件.sln /Build Release
set vs="D:\MS\Microsoft Visual Studio 10.0\Common7\IDE\devenv.com"
for %%i in (NewLife.Core XCode NewLife.CommonEntity NewLife.Mvc NewLife.Net XAgent XControl XTemplate XCoder) do (
	%vs% X组件.sln /Build Release /Project %%i
)

:: 4，拷贝DLL
copy ..\生成\N*.* ..\DLL\ /y
copy ..\生成\X*.* ..\DLL\ /y
del ..\DLL\*.config /f/s/q

:: 5，提交DLL更新
svn commit -m "自动编译" ..\DLL

:: 6，打包Src和DLL到FTP
set rar="C:\Program Files\WinRAR\RAR.exe" -m5 -md4096 -mt2 -s -z..\Src\Readme.txt
set zipfile=%date:~0,4%%date:~5,2%%date:~8,2%%time:~0,2%%time:~3,2%%time:~6,2%.rar
set dest=E:\快盘\新生命共享\X

:: 发布Src源码
rd XCoder\bin /s/q
rd XCoder\obj /s/q
set zipfile=Src.rar
%rar% -r a %zipfile% NewLife.Core\*.cs NewLife.CommonEntity\*.cs XControl\*.cs XAgent\*.cs XCode\Entity\*.cs XCode\DataAccessLayer\Common\*.cs XCoder\*.* XTemplate\Templating\Template.cs
move /y Src.%zipfile% %dest%\%zipfile%

:: 发布XCode例子源码
rd YWS\bin /s/q
rd YWS\obj /s/q
rd Web\bin /s/q
rd Web\Log /s/q
rd Web\App_Data /s/q
md Web\Bin
Copy ..\DLL\XControl.* Web\Bin\ /y
set zipfile=XCodeSample.rar
%rar% -r a %zipfile% YWS\*.* Web\*.*
move /y %zipfile% %dest%\%zipfile%

:: 发布DLL压缩包
:: 保存当前目录，并切换目录
pushd ..\DLL
::"C:\Program Files\WinRAR\WinRAR.exe" a DLL.rar *.dll *.exe *.pdb *.xml
set zipfile=DLL.rar
%rar% a %zipfile% *.dll *.exe *.pdb *.xml
move /y %zipfile% %dest%\%zipfile%
:: 恢复目录
popd