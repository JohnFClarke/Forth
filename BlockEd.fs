    \ RetroForth Block Editor (http://www.retroforth.org)
    \ * Released into the public domain *
    \
    \ This is the block editor from RetroForth Release 9.2.1
    \ It splits the normal 1k block into two smaller 512-byte blocks,
    \ the one on the left for code, and the one on the right for
    \ documentation/comments. Both are displayed side by side.
    \
    \ It makes use of some features specific to RetroForth, so it
    \ will not work on an ANS FORTH system without changes. 
   
   
    tib 1024 + constant <buffer>
    128 variable: <#blocks>
    <buffer>  variable: b0
    variable  current-block
   
   
    : there b0 @ ;
    : #-of-blocks <#blocks> @ ;
   
   
    : new there #-of-blocks 512 * 32 fill 0 current-block ! ; new
   
   
    : (block) @current-block : block 512 * there + ;
    : (line) 32 * (block) + ; 
   
   
    : p 2 current-block -! ;
    : n 2 current-block +! ;
    : d (line) 32 32 fill ;
    : x (block) 512 32 fill ;
    : eb (block) 512 eval ;
    : el (line) 32 eval ;
    : e 16 for 16 r - el next ;
    : s !current-block ;
    : i 0 swap : ia (line) + lnparse rot swap move ;
    : \ 1 s e ;
   
   
    loc:
     : \ '\ emit ; 
   
   
     : row dup 32 type 32 + ;
     : left# -16 + negate dup @base <if space then . ;
     : right# negate 32 + . ;
     : code\shadow row \ swap row swap space ;
     : rows 16 for r left# code\shadow r right# cr next ;
     : x--- 2 for ." +---:---+---:---" next ;
     : --- space space space x--- \ x--- cr ;
     : blocks @current-block 1+ block @current-block block ;
     here ] --- blocks rows 2drop --- ;
    ;loc is v
   
   
    : edit [[ clear v ]] { is ui } ;