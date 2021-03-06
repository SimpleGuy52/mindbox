select P.Id as ProductId, P.Name as ProductName, t2.Count as FirstBuyCount
from (
	select t.ProductId, COUNT(*) as [Count]
	from (
	  select *,
			 rank() over (partition by S.CustomerId order by S.DateCreated) as rnk
	  from sales as S
	) t
	where rnk = 1
	group by t.ProductId) t2
inner join Products as P
on P.Id = t2.ProductId