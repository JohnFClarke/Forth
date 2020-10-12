marker forget-inheritance
\ Inheritance
\ Every derived class must invoke baseObject at compile time 
\ and (baseObject) at run time
: baseObject [ cr ." compile baseObject " latest . ] ; 
: (baseObject) create cr ." execute (baseObject) " latest .  ;
