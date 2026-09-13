namespace Console;

public record Criteria(
    decimal LandAreaMin,
    decimal LandAreaMax,
    decimal InteriorAreaMin,
    decimal InteriorAreaMax,
    decimal PriceMin,
    decimal PriceMax
    );