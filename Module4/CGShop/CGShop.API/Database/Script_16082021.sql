USE [CGShopDB]
GO

/****** Object:  StoredProcedure [dbo].[sp_ChangeStatusCategory]    Script Date: 8/16/2021 11:05:45 AM ******/
DROP PROCEDURE [dbo].[sp_ChangeStatusCategory]
GO

/****** Object:  StoredProcedure [dbo].[sp_GetCategories]    Script Date: 8/16/2021 11:05:45 AM ******/
DROP PROCEDURE [dbo].[sp_GetCategories]
GO

/****** Object:  StoredProcedure [dbo].[sp_GetCategories]    Script Date: 8/16/2021 11:05:45 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Khoa Nguyen
-- Create date: 9/8/2021
-- Description:	Get all category
-- =============================================
CREATE PROCEDURE [dbo].[sp_GetCategories]
AS
BEGIN
	SELECT * FROM Category
	WHERE IsDeleted = 0
	ORDER BY CategoryId DESC
END
GO

/****** Object:  StoredProcedure [dbo].[sp_ChangeStatusCategory]    Script Date: 8/16/2021 11:05:45 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Khoa Nguyen
-- Create date: 16/8/2021
-- Description:	Change status category
-- =============================================
CREATE PROCEDURE [dbo].[sp_ChangeStatusCategory]
	@categoryId		INT,
	@status			BIT
AS
BEGIN
	BEGIN TRY
		UPDATE [dbo].[Category]
		   SET [Status] = (1 - @status)
		 WHERE CategoryId = @categoryId

		 SELECT @categoryId 
	END TRY
	BEGIN CATCH
		SELECT ERROR_NUMBER()
	END CATCH
END
GO

