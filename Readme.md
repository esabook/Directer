Simple logger for trapping argument of specific executable file to plain text.

as example if you want to know what about message that passed to `android fastboot` if you executing customer android desktop application.  So you can replace original `fastboot` file with this `directer`. 

But even this is very simplest program, you must rename old executable file as same as new `directer` name plus `-x`.

Example Steps:

1.  Rename and add `-x` as name, like `fastboot.exe` to `fastboot-x.exe`.
2. Copy single `directer.exe` file from debug/release folder of this project, then copy to folder some as `fastboot-x.exe` folder.
3. Rename `directer.exe` to `fastboot.exe`.
4. Happy trapping as middle spionase.



