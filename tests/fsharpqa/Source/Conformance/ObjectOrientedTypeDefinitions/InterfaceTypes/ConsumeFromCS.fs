// #Conformance #ObjectOrientedTypes #InterfacesAndImplementations 
// Verify consumption from C#
module TestModule

//Interface - empty
type I_000<'a> =
 interface
 end 

//Interface with inherits-decl 
type I_001<'a> =
 interface
  inherit I_000<'a>
 end

//Interface with type-defn-members 
type I_002<'a> =
 interface
  abstract Me: unit -> 'a
 end 
 
//Interface with inherits-decl & type-defn-members 
type I_003<'a> =
 interface
  inherit I_001<'a>
  abstract Home: 'a -> 'a
 end 

{new I_003<int> with member __.Home(i) = i }.Home({new I_002<int> with member __.Me() = 0}.Me()) |> exit

