.code

MyProc proc
; RDX - start idx
; RCX - pointer to first elemend of the array
; RBX - end idx
	mov RAX, RDX			;Copy start index to RAX
	shl RAX, 2				;Multiply RAX index by 4 (one index is 4 bytes) 
	add RCX, RAX			;Move to section start

	startLoop:
	mov EAX, [RCX]			;Move data from array to acumulator
	neg RAX					;Negate the acumulator
	mov [RCX], EAX			;Move data back into array
	add RCX, 4				;Increment array pinter
	inc RDX					;Increment array index
	cmp RDX, RBX			;Compare current index to end index ;doesnt work
	jnz startLoop			;Check if end of the array

	xor rax, rax			;Make RAX 0 for return
	ret						;Return good status code
	MyProc endp
end