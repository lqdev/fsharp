// #Warnings
//<Expects status="Error" span="(6,17)" id="FS0952">The accessibility specified for the type abbreviation 'Exported' is more than that specified for the abbreviated type 'Hidden'.</Expects>

module Library =
  type private Hidden = Hidden of unit
  type internal Exported = Hidden
    
exit 0