repo: name-sorter-global
creator: Jackson Grant 

PURPOSE
This script will sort a text file full of names.

SORTING ORDER
The script will sort the names alphabetically by last name, then it will order by given names, by starting at the first name, then moving to the second and third. 

RESTRICTIONS
Names must be in a text file, with each each name on a new line. Each line can have a maximum of 4 names, seperated by spaces. That's one last name and up to four given names. 

INPUT
Pass the text file into the script by calling it as an argument. 

OUTPUT
The script will output the sorted names into a text file called "sorted-names-list.txt".

SORTING METHOD
This script used a basic 'bubble sort' algorthim for sorting.

FUTURE IMPROVEMENTS 
Areas in which this script could be improved include: 
> implementing a faster sorting algorithm (e.g quicksort)
> stopping the bubblesort before it sorts the final line (because once it reaches the final line the file should already be sorted.)