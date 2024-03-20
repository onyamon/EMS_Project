# ความเป็นมาของโปรแกรม
#### โปรแกรมสร้างขึ้นเพื่อเก็บข้อมูลการเจ็บป่วยภายในมหาลัยขอนแก่น วิทยาเขตหนองคาย

# วัตถุประสงค์ของโปรแกรม
#### จัดทำขึ้นเพื่อให้ EMR ในชุมนุมกู้ชีพบันทึกข้อมูลการเจ็บป่วยในมหาลัยขอนแก่น วิทยาเขตหนองคาย เพื่อทำสรุปจำนวนการปฏิบัติหน้าที่ของ EMR แต่ละคนและบันทึกยอดการเจ็บป่วยของนักศึกษาในแต่ละเดือน

# ชื่อของผู้พัฒนาโปรแกรม
### นางสาวอรยมล  ประชานันท์  663450352-3

```mermaid
classDiagram
    Form2 -- Form1
    Form1 -- Login
    Form2 -- CSV
    Form2 -- EMSData
   Form1 :+void loginclick()
   Form1 :+string username
   Form1 :+int password
   Form2 :-void button1_Click()
   Form2 :-void logout_Click()
   Form2 :-void buttonCSV_Click()
    class Login{
      +String Username
      +int Password
      +bool checkUser()
    
    }
    class EMSData{
      +string Name
      +int Age
      +string branch
      +string symptom
      +string Drugallergy
      +string day
      +double T
      +string BP
      +int RR
      +int P
      +int O2Sat
      +string EMRCode
    
    }
    class CSV{
      +string sort
      +string path
      +bool csvfile()
    }
```