# ElevationTest Logs

This is a collection of test logs, further to my question at https://stackoverflow.com/questions/58845877/problem-accessing-native-executable-resources-in-uwp-package-in-user-installatio


These are the .pml logs from the program ElevationTest which you can get from the store at https://www.microsoft.com/store/apps/9NBTP50KD2ZB.  It's pretty much identical to the demonstration at https://stefanwick.com/2018/10/07/app-elevation-samples-part-3/, but with an added dialog to surface the error.

In order to produce these logs, I installed ElevationTest onto a non-admin account, started it, and clicked "Run background process as admin".  I got the UAC prompt, followed by a "file not found" error.  That log is in ElevationTestFailed.pml
I then switched to an admin account, and installed ElevationTest there.  Then I switched back to the original account, and clicked "Run background process as admin".  (Note, I did not stop and restart the app.  This is the same process as first time.)  This ran properly, again showing me the UAC prompt, but there was no error dialog, and Task Manager showed the bckground task running.  That log is in ElevtionTestSucceeded.pml.

You'll see messages from Vbox, and this was running in a VBOX virtual machine.  But the results are same even without a VM, and on other VM types.  I checked :-)
