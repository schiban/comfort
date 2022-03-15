IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ComFort]') AND type in (N'U'))
DROP TABLE [dbo].[ComFort]
GO

CREATE TABLE [dbo].[ComFort](
	[Proforma] [nvarchar](10) NOT NULL,
	[DataCompra] [datetime] NULL,
	[NomeCliente] [nvarchar](50) NULL,
	[MoradaCliente] [nvarchar](50) NULL,
	[ContatoCliente] [int] NULL,
	[NomeProduto] [nvarchar](20) NULL,
	[PrecoProduto] [float] NULL,
 CONSTRAINT [PK_ComFort] PRIMARY KEY CLUSTERED 
(
	[Proforma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

INSERT INTO [dbo].[ComFort]
           ([Proforma]
		   ,[DataCompra]
		   ,[NomeCliente]
		   ,[MoradaCliente]
           ,[ContatoCliente]
		   ,[NomeProduto]
		   ,[PrecoProduto]
           )
     VALUES
           ('PF2022000'
		   ,'20220101'
           ,'João Bandeira'
		   ,'Rua Bandeira 2'
		   ,910000000
		   ,'Sofa POO'
		   ,699.00
           ),
		   ('PF2022001'
		   ,'20220105'
           ,'Marcos Moreira'
		   ,'Rua Moreira 420'
		   ,961234567
		   ,'Cadeira POO'
		   ,80.00
           )
		   
GO


IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Gravar_ComFort]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Gravar_ComFort]
GO

CREATE Procedure [dbo].[Gravar_ComFort]
@Proforma nvarchar(10),
@DataCompra datetime,
@NomeCliente nvarchar(50),
@MoradaCliente nvarchar(50),
@ContatoCliente int,
@NomeProduto nvarchar(20),
@PrecoProduto float
As 
Begin

Begin Transaction
   
 IF (Select Count(*) From ComFort Where Proforma=@Proforma)=0
      Begin
         Insert Into ComFort (Proforma, DataCompra, NomeCliente, MoradaCliente, ContatoCliente, NomeProduto, PrecoProduto)
         Values (@Proforma, @DataCompra, @NomeCliente, @MoradaCliente, @ContatoCliente, @NomeProduto, @PrecoProduto)
      End
 Else
     Begin
         Update ComFort
         Set DataCompra=@DataCompra, NomeCliente=@NomeCliente, MoradaCliente=@MoradaCliente, ContatoCliente=@ContatoCliente, NomeProduto=@NomeProduto, PrecoProduto=@PrecoProduto
         Where Proforma=@Proforma
      End
 
      If @@error <>0
            Begin
               Rollback transaction
            End
      Else
            Begin
               Commit Transaction
            End
End

GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Obter_ComFort]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Obter_ComFort]
GO

CREATE Procedure [dbo].[Obter_ComFort]
@Proforma nvarchar(10)
As 
Begin

	Select * From ComFort Where Proforma=@Proforma
End


GO


IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Listar_ComFort]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Listar_ComFort]
GO

CREATE Procedure [dbo].[Listar_ComFort]
As 
Begin

	Select * From ComFort
End

GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Eliminar_ComFort]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Eliminar_ComFort]
GO

CREATE Procedure [dbo].[Eliminar_ComFort]
@Proforma nvarchar(10)
AS
Begin

Begin Transaction
         
      If (Select Count(*) From ComFort Where Proforma=@Proforma)<>0
          Begin
              Delete from ComFort
              Where Proforma=@Proforma
            End

       If @@error <>0
               Begin 
                  Rollback TRansaction
               End
       Else
            Begin
               Commit Transaction
            End

End


GO

