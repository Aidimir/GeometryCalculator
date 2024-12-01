SELECT
    pt.ProductName AS ProductName,
    ct.CategoryName AS CategoryName
FROM
    ProductsTable pt
        LEFT JOIN
    ProductCategoriesTable pct ON pt.ProductID = pct.ProductID
        LEFT JOIN
    CategoriesTable ct ON pct.CategoryID = ct.CategoryID;
