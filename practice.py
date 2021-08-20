from datetime import date
fields = "TIIP Test Item Info Pretest"




for field in fields.split(', '):
    # print(f"txt{field}.EditValue = this.el.{field};")
    #     print(f"public string {field} {{ get; set; }} = \"\";")


    name = ""
    for s in field.split()[1:]: name+=" "+s

    print(f"INSERT INTO Reference VALUES(3,\'{field.split()[0]}\', \'{name}\', null, 0, 1, \'TCSDEV1\Jason\', \'{date.today()}\', \'TCSDEV1\Jason\', \'{date.today()}\');")
    






