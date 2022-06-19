MATERIALS LIST ESTIMATOR

Getting Started
===============

Materials list estimator is a report builder for use under Microsoft Windows that allows 
for edit of individual segments each categorized differently. The four core segments are
"Wall", "Floor", "Roof" and "Opening". However, custom segment categories can be
user-defined. When satisfied with the result, a summary of the report can be viewed and then
exported to TSV.

Main form
=========
The main, or HOME form is the core of the application. A menu strip located at the top includes
I/O functions and a selection to VIEW REPORT. The I/O functions will be detailed in a
subsequent section.

The TABLE located in the center of the HOME form contains a list of all of the user's segments,
when the NEW button is clicked, they will be prompted to create a new segment. 
	The SEGMENT TYPE can be selected from one of the four core options in the combo box,
	alternatively, if the user wants to create a custom segment, simply type a custom name
	into the SEGMENT TYPE combo box. 
	Regardless of whether a custom type is defined, segments must be named. Once the criteria
	is satisfied, clicking the ACCEPT button will open the WORKSPACE form, explained in a later
	section.
	
Once a segment has been created, it will appear on the HOME form TABLE. If the user wishes to
edit the contents of this table, they must select the row with their mouse and click the EDIT
button. 

	If the user wants to rename the segment, they can do so by selecting the segment row and
	then either DOUBLE-CLICK the name. This will enable editing of the segment's name, and when
	the user is satisfied, they can press the ENTER key to accept the change. A confirmation
	pop-up will appear, clicking YES will commit the change.
	
	If the user decides not to commit their name change, pressing the ESC key will cancel the
	edit. 
	
If the user wishes to delete a segment, they can do so by clicking the row with their mouse
and clicking the DELETE button. 
	A confirmation pop-up will appear, clicking YES will delete the segment. This cannot be
	undone. 
	
The bottom of the HOME form will display a grand total of all the segments' costs added 
together. This is updated automatically whenever a segment is created, edited, or deleted.

Main form menu strip
====================
The FILE menu item contains selections relating to file operation.

Clicking the "New" item will prompt the user to save any unsaved changes, and then loads a
new project. 
	The existing project will be closed, be sure to save any unsaved changes. 
	
Clicking the "Open..." item will prompt the user to open an existing file. The supported
filetype is XML, and only XML files created by this application are supported.

Clicking the "Save" item will save the project to the existing file. If no such file exists,
the application will prompt the user to save to file. 

Clicking the "Save As..." item will allow the user to save the project to a custom location
and give it a custom filename. This will save the project as a unique XML file that can be
opened at a later time. 

Clicking the "View Report" item will compile and display a final report. Details on this report
are explored in a later section. 

The HELP menu item contains selections relating to assistance.

Clicking the "About" item will explain the purpose and developers of the application. 

Clicking the "Documentation" item will provide an online link to this file. 

Workspace form
==============
The WORKSPACE form is the primary interface for creating and editing segments. When a new
segment is created or an existing segment is edited, the WORKSPACE form will display the
segment's type and name at the bottom of the WORKSPACE form.

In the middle of the WORKSPACE form is a TABLE that contains all of the individual items the
user has created for the specified segment. Information includes the item's name, material,
description, quantity, unit cost, and total cost.
	New items can be added to the TABLE using the boxes located above it. Each box is located
	directly above the corresponding column that the box's contents will be stored in. 
		The ITEM box allows the user to select from a list of commonly-used items according to
		the segment's TYPE. If the user wishes to add an item that is not listed, they can
		type the custom item's name into this box instead of making a selection. 
		
		The MATERIAL box allows the user to select from a list of common materials associated
		with the selected ITEM. If a custom item has been defined, and or the user wishes to
		input a custom material, they can type the custom material's name into this box instead
		of making a selection. 
		
		The SIZE/DESCRIPTION box allows the user to input information regarding the item,
		this information can be anything relating to the item. If no such information is
		necessary for the report, the user may leave this box blank. 
		
		The QUANTITY box allows the user to input a quantity of the item they wish to include.
		This box will only allow numbers. 
		
		The UNIT COST box allows for the user to input the cost of an individual unit. The
		correct format is a number with no more than two decimal places. A currency symbol is
		not required, it will be added automatically.
		
		The CLEAR button erases all of the information inside the boxes. 
		
		When the user is satisfied with their inputs and selections, they must click the ADD
		ITEM button located in the bottom left corner of the WORKSPACE form. Alternatively the
		user can press the ENTER key. 
			This will automatically commit all of the user's inputs to the table, and provide
			an automatic calculation of the total cost of the item entry based on its QUANTITY
			and UNIT COST.
	Existing items can be deleted by clicking the item's row and clicking the DELETE ITEM
	button. A confirmation pop-up will appear, clicking the YES button will confirm the decision
	and delete the selected item. 
In the bottom right corner of the WORKSPACE form are SAVE and CANCEL buttons.
	Clicking the SAVE button will instantly save the segment. The user will then be prompted if
	they want to continue working on the segment. Clicking NO will automatically close the
	WORKSPACE form. 
	Clicking the CANCEL button will close the WORKSPACE form without saving it. If the user
	has unsaved changes, it will prompt the user to save them. If the YES button is clicked, 
	the WORKSPACE will discard all changes and close the form. 
Also in the bottom right corner of the WORKSPACE form is the GRAND TOTAL counter.
	This counter keeps track of the total cost of all items in the segment combined. It is
	updated automatically when an item is created or deleted.
	
Summary form
============
When the "View report" menu strip item on the HOME form is clicked, it will display the
SUMMARY form that shows the user a summary of all of the segments they created and the items
associated with each segment. 

This SUMMARY form cannot be edited, it merely serves as a preview of the TSV file that can be
exported by clicking the EXPORT TO .TSV button. 
	When this button is clicked, it will prompt the user to save a .tsv of their report. This
	file is unrelated to the XML project file they may have saved or loaded earlier and will
	not overwrite it.
		
	The application will then confirm or deny the success of the export. If successful, it will
	explain that .tsv files can be opened with any spreadsheet editing software.
		The software may prompt the user to verify some details about the delimited file. 
		If this happens, the user must confirm that the data is "Delimited" and that the
		delimiter is "Tab". An unformatted spreadsheet of the report will then be displayed
		for the user to edit and save as a spreadsheet file. 
		
		Important notice! The .tsv file is unformatted, formatting cannot be applied to the
		spreadsheet. To apply formatting, it must be edited in spreadsheet editing software
		and then saved as an appropriate spreadsheet type. 
		
Contact
=======
This application was created by Benjamin Russell and Brian LaTulip for SDEV240 final exam at
ITCC. While it is not meant for redistribution outside of the exam's parameters, if it has
been shared somewhere and the project should be brought up beyond the scope of the exam and
the class, interested parties can contact Ben at benalvinrussell@gmail.com
