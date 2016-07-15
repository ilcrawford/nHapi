using System;
using System.Collections.Generic;
using NHapi.Base.Log;
using NHapi.Model.V231.Group;
using NHapi.Model.V231.Segment;
using NHapi.Model.V231.Datatype;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;

namespace NHapi.Model.V231.Message

{
///<summary>
/// Represents a ADT_A17 message structure (see chapter [AAA]). This structure contains the 
/// following elements:
///<ol>
///<li>0: MSH (MSH - message header segment) </li>
///<li>1: EVN (EVN - event type segment) </li>
///<li>2: PID (PID - patient identification segment) </li>
///<li>3: PD1 (PD1 - patient additional demographic segment) optional </li>
///<li>4: PV1 (PV1 - patient visit segment-) </li>
///<li>5: PV2 (PV2 - patient visit - additional information segment) optional </li>
///<li>6: DB1 (DB1 - Disability segment) optional repeating</li>
///<li>7: OBX (OBX - observation/result segment) optional repeating</li>
///<li>8: PID (PID - patient identification segment) </li>
///<li>9: PD1 (PD1 - patient additional demographic segment) optional </li>
///<li>10: PV1 (PV1 - patient visit segment-) </li>
///<li>11: PV2 (PV2 - patient visit - additional information segment) optional </li>
///<li>12: DB1 (DB1 - Disability segment) optional repeating</li>
///<li>13: OBX (OBX - observation/result segment) optional repeating</li>
///</ol>
///</summary>
[Serializable]
public class ADT_A17 : AbstractMessage  {

	///<summary> 
	/// Creates a new ADT_A17 Group with custom IModelClassFactory.
	///</summary>
	public ADT_A17(IModelClassFactory factory) : base(factory){
	   init(factory);
	}

	///<summary>
	/// Creates a new ADT_A17 Group with DefaultModelClassFactory. 
	///</summary> 
	public ADT_A17() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

	///<summary>
	/// initalize method for ADT_A17.  This does the segment setup for the message. 
	///</summary> 
	private void init(IModelClassFactory factory) {
	   try {
	      this.add(typeof(MSH), true, false);
	      this.add(typeof(EVN), true, false);
	      this.add(typeof(PID), true, false);
	      this.add(typeof(PD1), false, false);
	      this.add(typeof(PV1), true, false);
	      this.add(typeof(PV2), false, false);
	      this.add(typeof(DB1), false, true);
	      this.add(typeof(OBX), false, true);
	      this.add(typeof(PID), true, false);
	      this.add(typeof(PD1), false, false);
	      this.add(typeof(PV1), true, false);
	      this.add(typeof(PV2), false, false);
	      this.add(typeof(DB1), false, true);
	      this.add(typeof(OBX), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating ADT_A17 - this is probably a bug in the source code generator.", e);
	   }
	}


	public override string Version
		{
			get{
			return Constants.VERSION;
			}
		}
	///<summary>
	/// Returns MSH (MSH - message header segment) - creates it if necessary
	///</summary>
	public MSH MSH { 
get{
	   MSH ret = null;
	   try {
	      ret = (MSH)this.GetStructure("MSH");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns EVN (EVN - event type segment) - creates it if necessary
	///</summary>
	public EVN EVN { 
get{
	   EVN ret = null;
	   try {
	      ret = (EVN)this.GetStructure("EVN");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns PID (PID - patient identification segment) - creates it if necessary
	///</summary>
	public PID PID { 
get{
	   PID ret = null;
	   try {
	      ret = (PID)this.GetStructure("PID");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns PD1 (PD1 - patient additional demographic segment) - creates it if necessary
	///</summary>
	public PD1 PD1 { 
get{
	   PD1 ret = null;
	   try {
	      ret = (PD1)this.GetStructure("PD1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns PV1 (PV1 - patient visit segment-) - creates it if necessary
	///</summary>
	public PV1 PV1 { 
get{
	   PV1 ret = null;
	   try {
	      ret = (PV1)this.GetStructure("PV1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns PV2 (PV2 - patient visit - additional information segment) - creates it if necessary
	///</summary>
	public PV2 PV2 { 
get{
	   PV2 ret = null;
	   try {
	      ret = (PV2)this.GetStructure("PV2");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of DB1 (DB1 - Disability segment) - creates it if necessary
	///</summary>
	public DB1 GetDB1() {
	   DB1 ret = null;
	   try {
	      ret = (DB1)this.GetStructure("DB1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of DB1
	/// * (DB1 - Disability segment) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public DB1 GetDB1(int rep) { 
	   return (DB1)this.GetStructure("DB1", rep);
	}

	/** 
	 * Returns the number of existing repetitions of DB1 
	 */ 
	public int DB1RepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("DB1").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the DB1 results 
	 */ 
	public IEnumerable<DB1> DB1s 
	{ 
		get
		{
			for (int rep = 0; rep < DB1RepetitionsUsed; rep++)
			{
				yield return (DB1)this.GetStructure("DB1", rep);
			}
		}
	}

	///<summary>
	///Adds a new DB1
	///</summary>
	public DB1 AddDB1()
	{
		return this.AddStructure("DB1") as DB1;
	}

	///<summary>
	///Removes the given DB1
	///</summary>
	public void RemoveDB1(DB1 toRemove)
	{
		this.RemoveStructure("DB1", toRemove);
	}

	///<summary>
	///Removes the DB1 at the given index
	///</summary>
	public void RemoveDB1At(int index)
	{
		this.RemoveRepetition("DB1", index);
	}

	///<summary>
	/// Returns  first repetition of OBX (OBX - observation/result segment) - creates it if necessary
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
	/// * (OBX - observation/result segment) - creates it if necessary
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
	/// Returns PID2 (PID - patient identification segment) - creates it if necessary
	///</summary>
	public PID PID2 { 
get{
	   PID ret = null;
	   try {
	      ret = (PID)this.GetStructure("PID2");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns PD12 (PD1 - patient additional demographic segment) - creates it if necessary
	///</summary>
	public PD1 PD12 { 
get{
	   PD1 ret = null;
	   try {
	      ret = (PD1)this.GetStructure("PD12");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns PV12 (PV1 - patient visit segment-) - creates it if necessary
	///</summary>
	public PV1 PV12 { 
get{
	   PV1 ret = null;
	   try {
	      ret = (PV1)this.GetStructure("PV12");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns PV22 (PV2 - patient visit - additional information segment) - creates it if necessary
	///</summary>
	public PV2 PV22 { 
get{
	   PV2 ret = null;
	   try {
	      ret = (PV2)this.GetStructure("PV22");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of DB12 (DB1 - Disability segment) - creates it if necessary
	///</summary>
	public DB1 GetDB12() {
	   DB1 ret = null;
	   try {
	      ret = (DB1)this.GetStructure("DB12");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of DB12
	/// * (DB1 - Disability segment) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public DB1 GetDB12(int rep) { 
	   return (DB1)this.GetStructure("DB12", rep);
	}

	/** 
	 * Returns the number of existing repetitions of DB12 
	 */ 
	public int DB12RepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("DB12").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the DB1 results 
	 */ 
	public IEnumerable<DB1> DB12s 
	{ 
		get
		{
			for (int rep = 0; rep < DB12RepetitionsUsed; rep++)
			{
				yield return (DB1)this.GetStructure("DB12", rep);
			}
		}
	}

	///<summary>
	///Adds a new DB1
	///</summary>
	public DB1 AddDB12()
	{
		return this.AddStructure("DB12") as DB1;
	}

	///<summary>
	///Removes the given DB1
	///</summary>
	public void RemoveDB12(DB1 toRemove)
	{
		this.RemoveStructure("DB12", toRemove);
	}

	///<summary>
	///Removes the DB1 at the given index
	///</summary>
	public void RemoveDB12At(int index)
	{
		this.RemoveRepetition("DB12", index);
	}

	///<summary>
	/// Returns  first repetition of OBX2 (OBX - observation/result segment) - creates it if necessary
	///</summary>
	public OBX GetOBX2() {
	   OBX ret = null;
	   try {
	      ret = (OBX)this.GetStructure("OBX2");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of OBX2
	/// * (OBX - observation/result segment) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public OBX GetOBX2(int rep) { 
	   return (OBX)this.GetStructure("OBX2", rep);
	}

	/** 
	 * Returns the number of existing repetitions of OBX2 
	 */ 
	public int OBX2RepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("OBX2").Length; 
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
	public IEnumerable<OBX> OBX2s 
	{ 
		get
		{
			for (int rep = 0; rep < OBX2RepetitionsUsed; rep++)
			{
				yield return (OBX)this.GetStructure("OBX2", rep);
			}
		}
	}

	///<summary>
	///Adds a new OBX
	///</summary>
	public OBX AddOBX2()
	{
		return this.AddStructure("OBX2") as OBX;
	}

	///<summary>
	///Removes the given OBX
	///</summary>
	public void RemoveOBX2(OBX toRemove)
	{
		this.RemoveStructure("OBX2", toRemove);
	}

	///<summary>
	///Removes the OBX at the given index
	///</summary>
	public void RemoveOBX2At(int index)
	{
		this.RemoveRepetition("OBX2", index);
	}

}
}
