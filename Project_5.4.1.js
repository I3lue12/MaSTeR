function updateSelection()
	{
		var v1 = window.document.f1.selection.selectedIndex;
		window.alert(v1);
	}

	function InitializeSelect()
	{
		var v1 = window.document.f1.selection.selectedIndex = -1;
	}
	function ValidateSelection()
	{
		var v1 = window.document.f1.selection.selectedIndex;
			if(v1 === -1)
			{
				window.alert("You select nothing");
			}
			else{
				window.alert("good job youve made your selection");
			}
	}
	
	function RemoveFromLeftAddRight(colLeft,colRight)
	{
		var selectedIndex =window.document.project5_4.left.selectedIndex;
		
		var value = window.document.project5_4.left.options[selectedIndex].value;
		
		var text = window.document.project5_4.left.options[selectedIndex].innerHTML;
		
		var newOption = window.document.createElement("option");
		
		newOption.text = value;

		window.document.project5_4.left.remove(selectedIndex);
		window.document.project5_4.right.add(newOption);
		// if(selectedIdex=getElementId=)
		// {

		// }

		// return newOption;


	}
	function RemoveFromRightAddLeft(colLeft,colRight)
	{
		var selectedIndex =window.document.project5_4.right.selectedIndex;
		var value = window.document.project5_4.right.options[selectedIndex].value;
		var text = window.document.project5_4.right.options[selectedIndex].innerHTML;
		var newOption = window.document.createElement("option");
		newOption.text = value;
		window.document.project5_4.right.remove(selectedIndex);
		window.document.project5_4.left.add(newOption);
	}