.code

MyProc proc
; RDX - start idx
; RCX - pointer to first elemend of the array
; RBX - end idx

startLoop:
mov RAX, [RCX]			;Move data from array to acumulator
neg RAX					;Negate the acumulator
mov [RCX], RAX			;Move data back into array
add RCX, 8				;Increment array pinter
inc RDX					;Increment array index
mov RAX, RDX			;Move array index	
sub RAX, RBX			;Subtract array end index from array index
JNE startLoop			;Check if end of the array

xor rax, rax
add rax, 10
ret
MyProc endp
end