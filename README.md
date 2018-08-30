copy all files names and catergories from the website and save to notepad
Export the above pages using http://Yourwiki/w/Special:Export
Remove the site info xml tag content and just keep <mediatag >
The SplitFiles.py script splits the big file into separate pages, converts the file names to replace / and : with underscores, because md files wont accept those file names
Remove unwanted xml tags using Deletetags.prj cause we need only title and content.
Convert to pandoc using the command ConvertToPandoc.cmd 
Use regex scripts to remove unwanted tages 
Initially we changed file names from : to _ and / to _ We need to change it back to : and _ in wiki links so that links will not break 
Images need to be manually inserted. Running these commands in md files will give the list of images that need to be inserted 
findstr /s /n /i /p png *
findstr /s /n /i /p jpg *

Download the images from old portal, save them in your local.
Upload the images in a folder in https://msazure.visualstudio.com/xxxx/xxxxx/folder
In the new portal, insert the image by giving full path in this format by just changing the image name -  ![](/Home/xxx/xxxx/yyy/images/400px-BN4-0101-0240-01c0_error.jpg =400x)

Manual process is required since the images names in files are like - 
Arista-7050QX-32.md:8:![Arista 7050QX-32](A7050-QX32.png "Arista 7050QX-32")
But on downloading the image from Site, the file names are prefixed with “300px”. 



