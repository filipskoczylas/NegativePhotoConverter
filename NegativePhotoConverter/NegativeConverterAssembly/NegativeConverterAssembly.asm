;Project: Negative photo converter
;File contains procedure used to convert 32-bit integer array values to their negatives
;Procedure is used to generate negative of a photo
;Author:	Filip Skoczylas
;Year:		2023/2024
;Semestre:	5
;Version:	1.0

;Project does not contain data section

;Code section of the project
.code

;Procedure: ConvertToNegative
;Procedure used to convert 32-bit integer array values to their negatives
;Procedure takes pointer to entire array as input
;Procedure modifies input array
;Modified data is put back into input array
;Procedure takes parameters: pointer to 32-bit integer array, index of first modified pixel, index of last modified index
;Procedure can be used on multiple threads
;Procedure takes parameters into registers: 
; RDX - start idx
; RCX - pointer to first element of the array
; RBX - end idx
;Procedure returns 0 if completed succesfully
MyProc proc


	mov RAX, RDX			;Copy start index to RAX
	shl RAX, 2				;Multiply RAX index by 4 (one index is 4 bytes) 
	add RCX, RAX			;Move to section start by adding RAX to RCX

	startLoop:
	mov EAX, [RCX]			;Move data from array to acumulator
	neg EAX					;Negate the acumulator
	mov [RCX], EAX			;Move data back into array
	add RCX, 4				;Increment array pointer
	inc RDX					;Increment array index
	cmp RDX, RBX			;Compare current index to end index
	jnz startLoop			;Check if end of the array

	xor RAX, RAX			;Make RAX 0 for return
	ret						;Return status code
	MyProc endp
end
;Procedure should always return 0