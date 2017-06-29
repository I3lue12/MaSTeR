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