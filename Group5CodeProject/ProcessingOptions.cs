///////////////////////////////////////////////////////////
//  Processing Options.cs
//  Implementation of the Class Processing Options
//  Generated by Enterprise Architect
//  Created on:      12-Feb-2018 9:03:13 AM
//  Original author: paulus_d
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



/// <summary>
/// This is a class that will hold the processing options
/// </summary>
public class ProcessingOptions : Option
{
	public const string FAST =  "1 Hour";
	public const string REGULAR = "Next Day";

	public ProcessingOptions(){
        items = new List<string>();
        items.Add(REGULAR);
        items.Add(FAST);
	}

}//end Processing Options