@echo off
setlocal

echo Building ModelDesign
.\Compiler\Opc.Ua.ModelCompiler.exe compile -version v104 -d2 ".\ModelDesign.xml" -cg ".\ModelDesign.csv" -o2 .\
echo Success!



