CREATE FUNCTION [CLRFunctions].[RegExMatch](@pattern NVARCHAR(MAX), @expression NVARCHAR(MAX))
RETURNS NVARCHAR(MAX)
AS EXTERNAL NAME [SQL.CLR.RegEx.Functions].[SQL.CLR.RegEx.Functions.RegExFunction].[Match];