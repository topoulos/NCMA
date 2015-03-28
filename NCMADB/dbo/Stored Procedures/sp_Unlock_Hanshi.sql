create proc sp_Unlock_Hanshi
as

SELECT au.username, aa.ApplicationName, password, passwordformat, passwordsalt
FROM aspnet_membership am
INNER JOIN aspnet_users au
ON (au.userid = am.userid)
INNER JOIN aspnet_applications aa
ON (au.applicationId = aa.applicationid)

DECLARE @return_value int
EXEC @return_value = [dbo].[aspnet_Membership_UnlockUser]
@ApplicationName = N'/',
@UserName = N'hanshi'
SELECT 'Return Value' = @return_value