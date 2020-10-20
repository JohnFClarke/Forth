marker forget-inheritance
\ Inheritance
\ Every derived class must invoke baseObject at compile time 
\ and (baseObject) at run time
: baseObject [ cr ." compile baseObject " here . ] ; \ immediate  
: (baseObject) create cr ." execute (baseObject) " here .  ;
