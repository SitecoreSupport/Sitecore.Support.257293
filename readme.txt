Patch Instructions:
1) Copy the given bin folder to your Sitecore instance's <website_name>/Website folder
2) Log into your Sitecore instance
3) In the launchpad select the "Desktop" application
4) On the bottom right corner of the desktop application click on "master" and change to "core" (switch from master to core database)
5) Go back to the launchpad (or select the sitecore button in the bottom left corner of the desktop application) and select the "Content Editor"
6) In the Content Editor navigate to the "/sitecore/client/Applications/LicenseOptions/License options" item
7) Go to the view tab at the top and make sure that "Standard fields" and "Raw values" are both checked
8) In the "License options" item scroll down to the "Layout" section and find the "Renderings" fields
9) Delete the single line text raw values string in the "Renderings" field and replace it with the contents of the "License options Renderings.txt"
