create database LocationCar;
	use LocationCar;
		create table UserTable( 	cin varchar(10) primary key,
									FullName varchar(75),
									address varchar(255),
									email varchar(50) unique,
									phone varchar(15) unique,
									DateNaissance date,
									Image Image,
									
									password varchar(255),
									LastActivity Date,
									permission varchar(15)
		);
		create table ReservedCars(	cin varchar(10) foreign key references usertable(cin),
									Matricule varchar(25) foreign key references cars(Matricule) unique,
									startDeo date,
									nbDay int
				);
		create table Contract( 		cin varchar(10) foreign key references usertable(cin),
									Matricule varchar(25) foreign key references cars(Matricule) unique,									
									startDeo date,
									nbDay int
		);
		create table Bill(			idBill int primary key identity(1,1),
									cin varchar(10) foreign key references userTable(cin),
									orderdate datetime,								
		);
		create table BillDetails(	idBill int foreign key references bill(idBill),
									matricule varchar(25) foreign key references cars(matricule),
									nbday int,
									price float									
		);

		create table Cars(			Matricule varchar(25) primary key,
									NomCar varchar(25),
									model varchar(25),
									color varchar(15),
									price float,
									description varchar(255),
									aviable varchar(4),
									ImageCar Image
		);

		
		create table promotion(		title varchar(25),
									Matricule varchar(25) foreign key references cars(Matricule) unique(Matricule),
									reduction float,
									description varchar(255),
			
									endDate date
		);
		create table Logs(          userid varchar(16),
									dt datetime,
									action varchar(255)
			);
		create table BlackList(		Img Image,
									iP varchar(15),
									macaddress varchar(16)
		);

































/*	create table userTable(		Cin varchar(10) primary key,
								FullName varchar(75),
								address varchar(255),
								email varchar(50) unique,
								phone varchar(15) unique,
								DateNaissance date,
								Image Image,
								password varchar(50),
								LastActivity Date,
								permission varchar(15)
		);
	create table cars(			Matricule varchar(25) primary key,
								NomCar varchar(25),
								model varchar(25),
								color varchar(15),
								price float,
								description varchar(255),
								aviable varchar(4),
								ImageCar Image
		);
	create table Contract( idcar varchar(25),
								idClient varchar(10),
								endDeo date
		);
	create table Bill(		idFacture int primary key identity(1,1),
								cin varchar(10) foreign key references userTable(cin),
								total float,
								orderdate datetime,
								priced varchar(5)								
		);
	create table BillDetails(idFacture int foreign key references facture(idFacture),
								idcar varchar(25) foreign key references cars(Matricule)

		);
	
	create table promotion(	title varchar(25),
							Matricule varchar(25) foreign key references cars(Matricule),
							reduction float,
							description varchar(255),
							endDate date
		);
	create table BlackList(		Img Image,
								iP varchar(15),
								macaddress varchar(16)
		);
*/
	create proc login 
		@a varchar(50),
		@b varchar(50)
	as
	begin
		select * from usertable where cin=@a or email=@a or phone=@a and password=@b;
	end





create proc searchUser 
		@a varchar(50)
	as
	begin
		select * from usertable where cin=@a and  permission='client'
	end
create proc DeleteUser 
		@a varchar(50)
	as
	begin
		delete from usertable where cin=@a and permission='client'
	end


	create proc signup
		@a varchar(10),
		@b varchar(75),
		@c varchar(255),
		@d varchar(50),
		@e varchar(15),
		@f date,
		@g Image,
		@h varchar(50),
		@i date,
		@j varchar(15)
	as
	begin
		insert into usertable values(@a,@b,@c,@d,@e,@f,@g,@h,@i,@j);
	end

	create proc signup
		@a varchar(10),
		@b varchar(75),
		@c varchar(255),
		@d varchar(50),
		@e varchar(15),
		@f date,
		@g Date,
		@h Image,
		@i varchar(50),
		@j varchar(15)
	as
	begin
		update usertable set cin=@a,fullname=@b,@c,@d,@e,@f,@g,@h,@i,@j;
	end

	create proc signup
		@a varchar(10),
		@b varchar(75),
		@c varchar(255),
		@d varchar(50),
		@e varchar(15),
		@f date,
		@g Date,
		@h Image,
		@i varchar(50),
		@j varchar(15)
	as
	begin
		insert into usertable values(@a,@b,@c,@d,@e,@f,@g,@h,@i,@j);
	end

	create proc deleteuser
	@a varchar(10)
	as
	delete from usertable where cin=@a

	create proc ShowClient
		@a varchar(10)
		as
		select cin,fullname,address,email,phone,Image,DateNaissance from userTable where cin=@a





		create proc login1
		@a varchar(50)
	as
	begin
		select * from usertable where cin=@a;
	end