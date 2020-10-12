require wrapper.fs 
	\ This will compile wrapper 
: integer 
[ ( wrapper ) 
cr ." compile integer "  latest . 
] (wrapper) 
cr ." execute integer " latest . 
cell  allot ;
