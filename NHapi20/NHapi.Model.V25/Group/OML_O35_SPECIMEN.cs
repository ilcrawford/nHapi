using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using System.Collections.Generic;
using NHapi.Model.V25.Segment;
using NHapi.Model.V25.Datatype;
using NHapi.Base.Model;

namespace NHapi.Model.V25.Group
{
///<summary>
///Represents the OML_O35_SPECIMEN Group.  A Group is an ordered collection of message 
/// segments that can repeat together or be optionally in/excluded together.
/// This Group contains the following elements: 
///<ol>
///<li>0: SPM (Specimen) </li>
///<li>1: OBX (Observation/Result) optional repeating</li>
///<li>2: OML_O35_SPECIMEN_CONTAINER (a Group object) repeating</li>
///</ol>
///</summary>
[Serializable]
public class OML_O35_SPECIMEN : AbstractGroup {

	///<summary> 
	/// Creates a new OML_O35_SPECIMEN Group.
	///</summary>
	public OML_O35_SPECIMEN(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(SPM), true, false);
	      this.add(typeof(OBX), false, true);
	      this.add(typeof(OML_O35_SPECIMEN_CONTAINER), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating OML_O35_SPECIMEN - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns SPM (Specimen) - creates it if necessary
	///</summary>
	public SPM SPM { 
get{
	   SPM ret = null;
	   try {
	      ret = (SPM)this.GetStructure("SPM");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of OBX (Observation/Result) - creates it if necessary
	///</summary>
	public OBX GetOBX() {
	   OBX ret = null;
	   try {
	      ret = (OBX)this.GetStructure("OBX");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of OBX
	/// * (Observation/Result) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public OBX GetOBX(int rep) { 
	   return (OBX)this.GetStructure("OBX", rep);
	}

	/** 
	 * Returns the number of existing repetitions of OBX 
	 */ 
	public int OBXRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("OBX").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the OBX results 
	 */ 
	public IEnumerable<OBX> OBXs 
	{ 
		get
		{
			for (int rep = 0; rep < OBXRepetitionsUsed; rep++)
			{
				yield return (OBX)this.GetStructure("OBX", rep);
			}
		}
	}

	///<summary>
	///Adds a new OBX
	///</summary>
	public OBX AddOBX()
	{
		return this.AddStructure("OBX") as OBX;
	}

	///<summary>
	///Removes the given OBX
	///</summary>
	public void RemoveOBX(OBX toRemove)
	{
		this.RemoveStructure("OBX", toRemove);
	}

	///<summary>
	///Removes the OBX at the given index
	///</summary>
	public void RemoveOBXAt(int index)
	{
		this.RemoveRepetition("OBX", index);
	}

	///<summary>
	/// Returns  first repetition of OML_O35_SPECIMEN_CONTAINER (a Group object) - creates it if necessary
	///</summary>
	public OML_O35_SPECIMEN_CONTAINER GetSPECIMEN_CONTAINER() {
	   OML_O35_SPECIMEN_CONTAINER ret = null;
	   try {
	      ret = (OML_O35_SPECIMEN_CONTAINER)this.GetStructure("SPECIMEN_CONTAINER");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of OML_O35_SPECIMEN_CONTAINER
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public OML_O35_SPECIMEN_CONTAINER GetSPECIMEN_CONTAINER(int rep) { 
	   return (OML_O35_SPECIMEN_CONTAINER)this.GetStructure("SPECIMEN_CONTAINER", rep);
	}

	/** 
	 * Returns the number of existing repetitions of OML_O35_SPECIMEN_CONTAINER 
	 */ 
	public int SPECIMEN_CONTAINERRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("SPECIMEN_CONTAINER").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the OML_O35_SPECIMEN_CONTAINER results 
	 */ 
	public IEnumerable<OML_O35_SPECIMEN_CONTAINER> SPECIMEN_CONTAINERs 
	{ 
		get
		{
			for (int rep = 0; rep < SPECIMEN_CONTAINERRepetitionsUsed; rep++)
			{
				yield return (OML_O35_SPECIMEN_CONTAINER)this.GetStructure("SPECIMEN_CONTAINER", rep);
			}
		}
	}

	///<summary>
	///Adds a new OML_O35_SPECIMEN_CONTAINER
	///</summary>
	public OML_O35_SPECIMEN_CONTAINER AddSPECIMEN_CONTAINER()
	{
		return this.AddStructure("SPECIMEN_CONTAINER") as OML_O35_SPECIMEN_CONTAINER;
	}

	///<summary>
	///Removes the given OML_O35_SPECIMEN_CONTAINER
	///</summary>
	public void RemoveSPECIMEN_CONTAINER(OML_O35_SPECIMEN_CONTAINER toRemove)
	{
		this.RemoveStructure("SPECIMEN_CONTAINER", toRemove);
	}

	///<summary>
	///Removes the OML_O35_SPECIMEN_CONTAINER at the given index
	///</summary>
	public void RemoveSPECIMEN_CONTAINERAt(int index)
	{
		this.RemoveRepetition("SPECIMEN_CONTAINER", index);
	}

}
}
