for %f in (D:\splitfiles\*.xml) do pandoc -s -f mediawiki -t markdown_mmd "%f" -o "D:\splitFilesmd\%~nf.md"
