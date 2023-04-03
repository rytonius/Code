from cx_Freeze import setup, Executable

setup (name='urlParse',
       version='1.0',
       description='Parse stuff',
       executables = [Executable("step1.py")])