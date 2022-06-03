# YouTubeDLext
Simple Tool to download a youtube m4a (audio file) within right click of any window

This is made for Windows 10 and will most likely work for both Windows 7 and 11


HOW TO SET UP
---------------
1 | Install Node.js located here. - https://nodejs.org/en/download/

2 | Install youtube-dl using Node.js, Documentation found here. - http://ytdl-org.github.io/youtube-dl/download.html

3 | Open regedit, this can be found by pressing Windows Button and Searching for "Regedit"

4 | Navigate to - Computer\HKEY_CLASSES_ROOT\Directory\Background\shell\

5 | Create a new Key inside of shell, name it "YouTubeDL"

6 | Create a second Key inside of "YouTubeDL" name it "command"

7 | Inside of Key 1 (YouTubeDL) Change the first (Default) string Value (by clicking under data on the key you're changing) to "YouTube Download"

8 | Create a new String Value inside of Key 1 (Right Click / New / String Value) make the name instead of (Default) to "Icon"

9 | Inside of "Icon" Change the Data to the Directory with the YouTubeDL Icon. Put the directory in between Quotation marks such as - "C:/User/Users/Source"

10 | Inside of Key 2 (command) Change the data of (Default) to the directory of the Executable of YouTubeDL inside of quotation marks 

Example: "C:User/Download/YouTubeDownload.exe"
---------------


HOW TO USE
---------------

Right Click inside of any Folder (Without Selecting another file) and Press "YouTube Download"

![image](https://user-images.githubusercontent.com/76859932/171837509-9a344c4e-244b-4aa8-b758-63d8e57c8b44.png)

---------------



TROUBLESHOOTING
---------------

If you get the error

![image](https://user-images.githubusercontent.com/76859932/171837710-df1727ce-fde2-4c0d-86be-6bc950fc43ad.png)

Please Make sure to have put the Key 2 (command) inside of Key 1 (YouTube-DL) Which should be located here -

Key 1 - Computer\HKEY_CLASSES_ROOT\Directory\Background\shell\YouTube DL

Key 2 - Computer\HKEY_CLASSES_ROOT\Directory\Background\shell\YouTube DL\command

Please Make sure that Key 2 has the data set to the directory set to the Executable Example -

The Data should look like :

"C:\Users\YOURUSERNAME\LOCATIONOFFILE\YouTubeDL.exe"

---------------
 
