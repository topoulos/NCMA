CREATE proc MembersByDojo_sp (@active int,@rpttype varchar(20),  
							@startdate datetime = null,
							@enddate datetime = null) as
							
	 SET FMTONLY OFF
	declare @sql varchar(max)
	
	select @sql = 'SELECT * From vwMemberGridLookup where active =' + cast(@active as CHAR(1)) 
	
	if @rpttype='JOINED'
		begin
			if @startdate is not null and @enddate is not null
				begin
					select @sql = @sql + ' and DateJoined BETWEEN  ''' + cast(@startdate as varchar(20)) + ''' AND ''' + CAST(@enddate as varchar(20)) + ''''
				end
		end
	if @rpttype='RANK'
		begin
			if @startdate is not null and @enddate is not null
				begin
					select @sql = @sql + ' and DateOfRank BETWEEN  ''' + cast(@startdate as varchar(20)) + ''' AND ''' + CAST(@enddate as varchar(20)) + ''''
				end
			
		end
		
	
	exec (@sql)