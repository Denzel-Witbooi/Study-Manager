   create database StudentInfoAsp;
   use StudentInfoAsp;

   
   drop table Module;
   /* Drop the module table cause migrations changes the datetime to datetime2 */

	CREATE TABLE Module (
	[Id] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[UserName] [nvarchar](max) NULL,
	[ModuleCode] [nvarchar](max) NOT NULL,
	[ModuleName] [nvarchar](max) NOT NULL,
	[Credits] [int] NOT NULL,
	[ClassHrsPW] [int] NOT NULL,
	[StartDate] [datetime] NOT NULL,
	[SemesterWeek] [int] NOT NULL,
	[DateStudied] [datetime] NOT NULL,
	[HoursWorked] [int] NOT NULL,
	[SelfStudyHrsReq] [int] NOT NULL,
	[SelfStudyHrsRem] [int] NOT NULL,
	[Weeks] [int] NOT NULL,
	);

	/* Copy Conncection String into appsettings.json */

	/* INSERT STATEMENTS FOR MODULE TABLE  */

	
	
	/* Username: Frank01 Password: 1Frank01!*/
	/* Username: Jane01 Password: 1Jane01!*/
	/* Username: Denzel Password: 1Denzel01!*/
	/* Username: JohnDoe Password: 1JohnDoe01!*/


INSERT INTO Module(UserName,ModuleCode,ModuleName ,Credits,ClassHrsPW,StartDate,SemesterWeek,DateStudied,HoursWorked, SelfStudyHrsReq,SelfStudyHrsRem,Weeks) 
VALUES 
 ( 
	'Frank01','WEDE6212', ' Web dev',11,4,11/17/2021, 15,12/15/2021,1, 7, 6, 3 
 ),
  ( 
	'Frank01','DATA6212', ' Database',11,4,11/17/2021, 15,12/15/2021,1, 7, 6, 3 
 ),
  ( 
	'Frank01','ANTE6211', 'Analytics',11,4,11/17/2021, 15,12/15/2021,1, 7, 6, 3 
 ),
  ( 
	'Frank01','HCIN6212', 'Human Computer Interaction',11,4,11/17/2021, 15,12/15/2021,1, 7, 6, 3 
 ),
  ( 
	'Frank01','IPMA6212', 'IT PROJECT MANAGEMENT',11,4,11/17/2021, 15,12/15/2021,1, 7, 6, 3  
 ),
  ( 
	'Jane01','BUCO6211', 'Business communication',11,4,11/17/2021, 15,12/15/2021,1, 7, 6, 3 
 ),
  ( 
	'Jane01','ITSA6211', 'IT Scholar',11,4,11/17/2021, 15,12/15/2021,1, 7, 6, 3 
 ),
  ( 
	'Jane01','PROG6212', 'Programming 2B',11,4,11/17/2021, 15,12/15/2021,1, 7, 6, 3 
 ),
  ( 
	'Jane01','PROG6211', 'Programming 2A',11,4,11/17/2021, 15,12/15/2021,1, 7, 6, 3 
 ),
  ( 
	'Jane01','SAND6212', 'System Analysis and Design',11,4,11/17/2021, 15,12/15/2021,1, 7, 6, 3  
 ),
 ( 
	'Denzel','BUCO6211', 'Business communication',11,4,11/17/2021, 15,12/15/2021,1, 7, 6, 3 
 ),
 ( 
	'Denzel','PROG6212', 'Programming 2B',11,4,11/17/2021, 15,12/15/2021,1, 7, 6, 3 
 ),
 ( 
	'Denzel','HCIN6212', 'Human computer interaction',11,4,11/17/2021, 15,12/15/2021,1, 7, 6, 3 
 ),
  ( 
	'JohnDoe','PROG6212', 'Programming 2B',11,4,11/17/2021, 15,12/15/2021,1, 7, 6, 3 
 ),
  ( 
	'JohnDoe','PROG6211', 'Programming 2A',11,4,11/17/2021, 15,12/15/2021,1, 7, 6, 3 
 ),
  ( 
	'JohnDoe','BUCO6211', 'Business communication',11,4,11/17/2021, 15,12/15/2021,1, 7, 6, 3 
 ),

  ( 
	'JohnDoe','HCIN6212', 'Human computer interaction',11,4,11/17/2021, 15,12/15/2021,1, 7, 6, 3 
 );

