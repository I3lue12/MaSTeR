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
	
	function RemoveFromLeftAddRight()
	{
		var selectedIndex =window.document.project5_4.left.selectedIndex;
		
		var value = window.document.project5_4.left.options[selectedIndex].value;
		
		var text = window.document.project5_4.left.options[selectedIndex].innerHTML;
		
		var newOption = window.document.createElement("option");
		
		NewOption.text = value;

		window.document.project5_4.left.remove(selectedIndex);
		window.document.project5_4.right.add(newOption);
	}
	