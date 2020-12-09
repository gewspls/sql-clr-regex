CREATE FUNCTION [CLRFunctions].[RegExMatchPosition](@pattern NVARCHAR(MAX), @expression NVARCHAR(MAX))
RETURNS INT
AS EXTERNAL NAME [SQL.CLR.RegEx.Functions].[SQL.CLR.RegEx.Functions.RegExFunction].[MatchPosition];