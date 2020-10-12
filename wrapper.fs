require inheritance.fs 
    \ This will compile inheritance 
: wrapper baseObject 
[ 
cr ." compile wrapper " latest . 
] (baseObject) ;         
 : (wrapper) (baseObject)  
cr ." execute (wrapper) "  latest . ; 
