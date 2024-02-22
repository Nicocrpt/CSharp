
def splitChaineInit(operation) :
    operasplit = []
    number = ""
    for char in range (0, len(operation)) :
        if operation[char] in ['1','2','3','4','5','6', '7','8','9','0','.','+','-','*','^','/','%'] :
            if operation[char].isdigit()  or operation[char] in ['.', '*', '/', '^', '%','-'] :
                if operation[char] == '-' :
                    if operation[char-1] in ['*', '/', '^', '%','+'] :
                        number += operation[char]
                    else :
                        if number != "" :
                            operasplit.append(number)
                        operasplit.append(operation[char])
                        number = ""
                else :
                    number += operation[char]
            
            elif operation[char] == '+' :
                if number != "" :
                    operasplit.append(number)
                operasplit.append(operation[char])
                number = ""
        else :
            operasplit = '\nOperation non correcte !'
            return operasplit

    if number != "" :
        operasplit.append(number)
    if operasplit[0] == '-' :
        operasplit[0] += operasplit[1]
        operasplit.remove(operasplit[1])
    return operasplit

def splitOperateursPrio(lsOperationSplitted) :
    opMoreSplitted = []
    for e in lsOperationSplitted :
        primarySplit = []
        numb = ''
        if e in ['+', '-'] :
            primarySplit.append(e)
            # print(primarySplit)
            opMoreSplitted.append(primarySplit)
        else :
            for c in e :
                if c.isdigit() or c == '.'  or c == '-' :
                    numb += c
                elif c in ['*','/','%','^'] :
                    if numb != '' :
                        primarySplit.append(numb)
                    primarySplit.append(c)
                    numb = ''
            if numb != '' :
                primarySplit.append(numb)
            opMoreSplitted.append(primarySplit)
    return opMoreSplitted

def calcOperateursPrio(operation) :

    for e in operation :
        nombres = 0
        i = 0
        while i < len(e) :
            if e[i] == '^' :
                nombres = float(e[i-1])**float(e[i+1])
                e[i] = nombres
                e.remove(e[i-1])
                e.remove(e[i])
            i += 1

    for e in operation :
        nombres = 0
        while len(e) > 1 :
            h = 0
            while h < len(e) :
                if e[h] == '/' :
                    if float(e[h+1]) != 0 :
                        nombres = float(e[h-1])/float(e[h+1])
                        e[h] = nombres
                        e.remove(e[h-1])
                        e.remove(e[h])
                    else :
                        newoperation = '\nDivision par 0 impossible\n'
                        return newoperation
                elif e[h] == '*' :
                    nombres = float(e[h-1])*float(e[h+1])
                    e[h] = nombres
                    e.remove(e[h-1])
                    e.remove(e[h])
                elif e[h] == '%' :
                    nombres = float(e[h-1])%float(e[h+1])
                    e[h] = nombres
                    e.remove(e[h-1])
                    e.remove(e[h])
                h += 1
    newoperation = []
    for e in operation :
        newoperation.append(e[0])
    
    return newoperation

def calcOperateursSecond(subfinalLs) :

    LastList = []
    
    c = 0
    while c < len(subfinalLs) :
        nombre = 0
        if c == 0 :
            LastList.append(float(subfinalLs[c]))
        if c > 0 :
            if subfinalLs[c] == '+':
                nombre = float(subfinalLs[c+1])
            elif subfinalLs[c] == '-' :
                nombre = -float(subfinalLs[c+1])
            LastList.append(nombre)
            nombre = 0
        c += 1

    resultat = 0

    for i in range (0,len(LastList)) :
        resultat += LastList[i]
        
    if resultat - int(resultat) == 0 :
        resultat = int(resultat)
    
    return resultat

def operation(operation, viability) :

    op = splitChaineInit(operation)
    if op == str(op) :
        print(op)
        viability = True
    else :
        op = splitOperateursPrio(op)
        op = calcOperateursPrio(op)
        if op == str(op) :
            print(op)
            viability = True
        else :   
            
            op = calcOperateursSecond(op)
            print(f'\n= {op}')
            viability = False
    return viability


def straightCalc(operation) :

    op = splitChaineInit(operation)
    if op == str(op) :
        print(op)
    else :
        op = splitOperateursPrio(op)
        op = calcOperateursPrio(op)
        if op == str(op) :
            print(op)
        else :   
            op = calcOperateursSecond(op)
    return op

def ridParentheses(operation) :
    if '(' in operation :
        split = operation.split('(')
        split2 = []
        for e in split :
            if ')' in e :
                secsplit = e.split(')')
                if secsplit[1] != '' :
                    parenthResult = straightCalc(secsplit[0])
                    split2.append(parenthResult)
                    split2.append(secsplit[1])
                else :
                    secsplit.pop()
                    parenthResult = straightCalc(secsplit[0])
                    split2.append(parenthResult)
            else :
                split2.append(e)
        split2 = ''.join(str(x) for x in split2)
    else :
        split2 = operation
    return split2


rtr = True
print("\n-~-~-~-~-| Calulatrice |-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-\n")
while rtr == True :
    ope = str(input('Operation : '))
    ope = ridParentheses(ope)
    rtr = operation(ope, rtr)
    if rtr == False :
        ans = str(input('\nVoulez vous effectuer une nouvelle operation (o/n) : '))
        if ans != 'o' :
            rtr = False
            print("\n-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-| Bye ! |-~-~-~-~-\n")
        else : 
            rtr = True
            print("\n    -~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~—~-~-~-~-    \n")

