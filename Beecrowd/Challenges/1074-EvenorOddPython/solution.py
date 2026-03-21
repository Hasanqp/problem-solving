N = int(input())

for i in range(N):
    X = int(input())
    
    if X == 0:
        print("NULL")
    else:
        result = ""
        
        if X % 2 == 0:
            result += "EVEN "
        else:
            result += "ODD "
        
        if X > 0:
            result += "POSITIVE"
        else:
            result += "NEGATIVE"
        
        print(result)
