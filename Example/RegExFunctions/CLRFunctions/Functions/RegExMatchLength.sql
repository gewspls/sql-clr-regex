CREATE FUNCTION [CLRFunctions].[RegExMatchLength](@pattern NVARCHAR(MAX), @expression NVARCHAR(MAX))
RETURNS INT
AS EXTERNAL NAME [SQL.CLR.RegEx.Functions].[SQL.CLR.RegEx.Functions.RegExFunction].[MatchLength];