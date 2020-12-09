CREATE FUNCTION [CLRFunctions].[RegExMatchReplace](@pattern NVARCHAR(MAX), @expression NVARCHAR(MAX), @replacement NVARCHAR(MAX))
RETURNS NVARCHAR(MAX)
AS EXTERNAL NAME [SQL.CLR.RegEx.Functions].[SQL.CLR.RegEx.Functions.RegExFunction].[Replace];