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
/// Represents a RAR_RAR message structure (see chapter [AAA]). This structure contains the 
/// following elements:
///<ol>
///<li>0: MSH (MSH - message header segment) </li>
///<li>1: MSA (MSA - message acknowledgment segment) </li>
///<li>2: ERR (ERR - error segment) optional </li>
///<li>3: RAR_RAR_DEFINITION (a Group object) repeating</li>
///<li>4: DSC (DSC - Continuation pointer segment) optional </li>
///</ol>
///</summary>
[Serializable]
public class RAR_RAR : AbstractMessage  {

	///<summary> 
	/// Creates a new RAR_RAR Group with custom IModelClassFactory.
	///</summary>
	public RAR_RAR(IModelClassFactory factory) : base(factory){
	   init(factory);
	}

	///<summary>
	/// Creates a new RAR_RAR Group with DefaultModelClassFactory. 
	///</summary> 
	public RAR_RAR() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

	///<summary>
	/// initalize method for RAR_RAR.  This does the segment setup for the message. 
	///</summary> 
	private void init(IModelClassFactory factory) {
	   try {
	      this.add(typeof(MSH), true, false);
	      this.add(typeof(MSA), true, false);
	      this.add(typeof(ERR), false, false);
	      this.add(typeof(RAR_RAR_DEFINITION), true, true);
	      this.add(typeof(DSC), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating RAR_RAR - this is probably a bug in the source code generator.", e);
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
	/// Returns MSA (MSA - message acknowledgment segment) - creates it if necessary
	///</summary>
	public MSA MSA { 
get{
	   MSA ret = null;
	   try {
	      ret = (MSA)this.GetStructure("MSA");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns ERR (ERR - error segment) - creates it if necessary
	///</summary>
	public ERR ERR { 
get{
	   ERR ret = null;
	   try {
	      ret = (ERR)this.GetStructure("ERR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of RAR_RAR_DEFINITION (a Group object) - creates it if necessary
	///</summary>
	public RAR_RAR_DEFINITION GetDEFINITION() {
	   RAR_RAR_DEFINITION ret = null;
	   try {
	      ret = (RAR_RAR_DEFINITION)this.GetStructure("DEFINITION");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of RAR_RAR_DEFINITION
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public RAR_RAR_DEFINITION GetDEFINITION(int rep) { 
	   return (RAR_RAR_DEFINITION)this.GetStructure("DEFINITION", rep);
	}

	/** 
	 * Returns the number of existing repetitions of RAR_RAR_DEFINITION 
	 */ 
	public int DEFINITIONRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("DEFINITION").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the RAR_RAR_DEFINITION results 
	 */ 
	public IEnumerable<RAR_RAR_DEFINITION> DEFINITIONs 
	{ 
		get
		{
			for (int rep = 0; rep < DEFINITIONRepetitionsUsed; rep++)
			{
				yield return (RAR_RAR_DEFINITION)this.GetStructure("DEFINITION", rep);
			}
		}
	}

	///<summary>
	///Adds a new RAR_RAR_DEFINITION
	///</summary>
	public RAR_RAR_DEFINITION AddDEFINITION()
	{
		return this.AddStructure("DEFINITION") as RAR_RAR_DEFINITION;
	}

	///<summary>
	///Removes the given RAR_RAR_DEFINITION
	///</summary>
	public void RemoveDEFINITION(RAR_RAR_DEFINITION toRemove)
	{
		this.RemoveStructure("DEFINITION", toRemove);
	}

	///<summary>
	///Removes the RAR_RAR_DEFINITION at the given index
	///</summary>
	public void RemoveDEFINITIONAt(int index)
	{
		this.RemoveRepetition("DEFINITION", index);
	}

	///<summary>
	/// Returns DSC (DSC - Continuation pointer segment) - creates it if necessary
	///</summary>
	public DSC DSC { 
get{
	   DSC ret = null;
	   try {
	      ret = (DSC)this.GetStructure("DSC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
