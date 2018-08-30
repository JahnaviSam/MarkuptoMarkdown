import xml.etree.ElementTree as ET
context = ET.iterparse(r'''C:\TheLastTime\BigFile\BigFile.xml''', events=('end', ))
for event, elem in context:
    if elem.tag == 'page':       
        title = elem.find('title').text
        newtitle = title.replace('/','_').replace(':','_')
        filename = format(newtitle + ".xml")
        with open(filename, 'wb') as f:
            f.write(ET.tostring(elem)) 
