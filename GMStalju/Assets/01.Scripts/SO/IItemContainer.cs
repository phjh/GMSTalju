public interface IItemContainer
{
	bool ContainsResource(ResourceSO resource);
	bool RemoveResource(ResourceSO resource);
	bool AddResource(ResourceSO resource);
	bool IsFull();
}
