SELECT  productName as Name,CategoryName as Category FROM Product 
						LEFT JOIN ProductCategories ON Product.id = ProductCategories.productId
						LEFT JOIN Category ON categoryId  = Category.id
								
             
