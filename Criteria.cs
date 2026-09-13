namespace Console;

public record Criteria(
    decimal landAreaMin,
    decimal landAreaMax,
    decimal interiorAreaMin,
    decimal interiorAreaMax,
    decimal priceMin,
    decimal priceMax
    );