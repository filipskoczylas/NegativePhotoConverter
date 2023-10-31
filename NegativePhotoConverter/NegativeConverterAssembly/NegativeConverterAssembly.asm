.code

MyProc proc
; RDX - start idx
; RCX - pointer to first elemend of the array
; RBX - end idx
; Registers will be modified in future to match their purposes
mov RAX, 4				;Copy 4 to RAX
mov R8, RDX				;Copy start index to R8
add R8, R8
add R8, R8				;Multipy start index (R8) 4 times (one idex is 4 bytes)
add RCX, R8				;Move to section start

startLoop:
mov EAX, [RCX]			;Move data from array to acumulator
neg RAX					;Negate the acumulator
mov [RCX], EAX			;Move data back into array
add RCX, 4				;Increment array pinter
inc RDX					;Increment array index
mov RAX, RDX			;Move array index	
sub RAX, RBX			;Subtract array end index from array index
JNE startLoop			;Check if end of the array

xor rax, rax			;Test
add rax, 10
ret
MyProc endp
end