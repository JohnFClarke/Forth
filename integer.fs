require wrapper.fs 
	\ This will compile wrapper 
: integer 
[ ( wrapper ) 
cr ." compile integer "  here . 
] (wrapper) 
cr ." execute integer " here . 
cell  allot ;
