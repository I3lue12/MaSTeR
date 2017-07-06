function CalcBM(age)
	{
		this.age = age;
		this.maximumHeartRate = 220 - this.age;
		this.minimumRec = 0.5 * this.maximumHeartRate;
		this.maximumRec = 0.85 * this.maximumHeartRate;

		this.GetMinHR = GetMinHR;
		this.GetMinHR = GetMaxHR;
	}

	function GetMinHR()
	{
		return this.minimumRec;
	}

	function GetMaxHR()
	{
		return this.maximumRec;
	}

	function UpdateHR()
	{
		var age = parseFloat(document.theForm.age.value);
		
		var HRcalc = new CalcBM(age);
		var min = HRcalc.GetMinHR();
		var max = HRcalc.GetMaxHR();
		window.alert(min);
		window.alert(max);
		// document.theForm.min.innerHTML = min.toString();
		// document.theForm.max.innerHTML = max.toString();

		// document.getElementById("min") = min.toString();
	}