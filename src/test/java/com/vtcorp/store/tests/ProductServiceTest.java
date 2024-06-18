package com.vtcorp.store.tests;

import com.vtcorp.store.dtos.ProductDTO;
import com.vtcorp.store.entities.Brand;
import com.vtcorp.store.entities.Category;
import com.vtcorp.store.entities.Product;
import com.vtcorp.store.mappers.ProductMapper;
import com.vtcorp.store.repositories.BrandRepository;
import com.vtcorp.store.repositories.CategoryRepository;
import com.vtcorp.store.repositories.ProductRepository;
import com.vtcorp.store.services.ProductService;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;
import org.junit.jupiter.api.extension.ExtendWith;
import org.mockito.InjectMocks;
import org.mockito.Mock;
import org.mockito.junit.jupiter.MockitoExtension;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.context.SpringBootTest;
import org.springframework.boot.test.mock.mockito.MockBean;

import java.util.Arrays;
import java.util.List;
import java.util.Optional;

import static org.junit.jupiter.api.Assertions.*;
import static org.mockito.Mockito.*;

import static org.junit.jupiter.api.Assertions.assertEquals;
import static org.junit.jupiter.api.Assertions.assertNotNull;
import static org.mockito.Mockito.when;

@ExtendWith(MockitoExtension.class)
@SpringBootTest
public class ProductServiceTest {

    @MockBean
    private ProductRepository productRepository;

    @MockBean
    private BrandRepository brandRepository;

    @MockBean
    private CategoryRepository categoryRepository;

    @MockBean
    private ProductMapper productMapper;

    @Autowired
    private ProductService productService;

    private ProductDTO productDTO;
    private Product addProduct;
    private Brand brand;
    List<Category> categories;
    List<Long> categoryIds;
    private Category category;
    private Category category2;
    private List<Product> mockActiveProducts;
    private List<Product> mockAllProducts;
    private Product product1;
    private Product product2;
    private Product product3;
    private Product product4;

    @BeforeEach
    public void setUp() {
        // Mock data setup
        product1 = new Product();
        product1.setProductId(1L);
        product1.setName("Product 1");
        product1.setActive(true);

        product2 = new Product();
        product2.setProductId(2L);
        product2.setName("Product 2");
        product2.setActive(true);

        product3 = new Product();
        product3.setProductId(3L);
        product3.setName("Product 3");
        product3.setActive(false);

        product4 = new Product();
        product4.setProductId(4L);
        product4.setName("Product 4");
        product4.setActive(false);

        // Setup mock data for the tests
        brand = new Brand();
        brand.setBrandId(1);
        brand.setName("Brand 1");

        productDTO = ProductDTO.builder()
                .productId(5L)
                .name("Product 1")
                .listedPrice(150.0)
                .sellingPrice(100.0)
                .description("Product Description")
                .noSold(0)
                .stock(50)
                .active(true)
                .brandId(brand.getBrandId())
                .build();

        addProduct = new Product();
        addProduct.setProductId(productDTO.getProductId());
        addProduct.setName(productDTO.getName());
        addProduct.setListedPrice(productDTO.getListedPrice());
        addProduct.setSellingPrice(productDTO.getSellingPrice());
        addProduct.setDescription(productDTO.getDescription());
        addProduct.setNoSold(productDTO.getNoSold());
        addProduct.setStock(productDTO.getStock());
        addProduct.setActive(productDTO.isActive());
        addProduct.setBrand(brand);
        addProduct.setCategories(categories);

    }

    @Test
    public void testGetActiveProducts_success() {
        // Only include active products in the mock return list
        mockActiveProducts = Arrays.asList(product1, product2);
        // Mocking repository method to return only active products
        when(productRepository.findByActive(true)).thenReturn(mockActiveProducts);

        // Call the service method
        List<Product> activeProducts = productService.getActiveProducts();

        // Assertions
        assertEquals(2, activeProducts.size()); // Expecting only 2 active product
        assertEquals("Product 1", activeProducts.get(0).getName()); // Ensure it's the correct active product
        assertEquals("Product 2", activeProducts.get(1).getName());
    }

    @Test
    public void testGetActiveProducts_NoActiveProducts() {
        // Only include active products in the mock return list
        mockActiveProducts = Arrays.asList();
        // Mocking repository method to return only active products
        when(productRepository.findByActive(true)).thenReturn(mockActiveProducts);

        // Call the service method
        List<Product> activeProducts = productService.getActiveProducts();

        // Assertions
        assertEquals(0, activeProducts.size()); // Expecting  0 active product

    }

    @Test
    public void testGetAllProducts_success() {
        // All products in the mock return list
        mockAllProducts = Arrays.asList(product1, product2, product3, product4);
        // Mocking repository method to return all products
        when(productRepository.findAll()).thenReturn(mockAllProducts);
        // Call the service method
        List<Product> allProducts = productService.getAllProducts();

        // Check the result
        assertEquals(4, allProducts.size()); // Expect to have 3 products in the returned list
        assertEquals("Product 1", allProducts.get(0).getName());
        assertEquals("Product 2", allProducts.get(1).getName());
        assertEquals("Product 3", allProducts.get(2).getName());
        assertEquals("Product 4", allProducts.get(3).getName());
    }

    @Test
    public void testGetAllProducts_EmptyProductList() {
        // All products in the mock return list
        mockAllProducts = Arrays.asList();
        // Mocking repository method to return all products
        when(productRepository.findAll()).thenReturn(mockAllProducts);
        // Call the service method
        List<Product> allProducts = productService.getAllProducts();

        // Check the result
        assertEquals(0, allProducts.size()); // Expect to have 0 products in the returned list

    }

    @Test
    public void testAddProduct_Success() {
        category = new Category();
        category.setCategoryId(1);
        category.setName("Category 1");

        category2 = new Category();
        category2.setCategoryId(2);
        category2.setName("Category 2");

        // Initialize categoryIds
        categoryIds = Arrays.asList(1L, 2L);
        categories = Arrays.asList(category);
        productDTO.setCategoryIds(categoryIds);

        // Mocking repository and mapper methods
        when(brandRepository.findById(productDTO.getBrandId())).thenReturn(Optional.of(brand));
        // Example of mocking category repository
        when(categoryRepository.findAllById(productDTO.getCategoryIds())).thenReturn(categories);
        when(productMapper.toEntity(productDTO)).thenReturn(addProduct);
        when(productRepository.save(addProduct)).thenReturn(addProduct);

        // Call the service method
        Product createdProduct = productService.addProduct(productDTO);

        // Assertions
        assertNotNull(createdProduct);
        assertEquals(addProduct.getName(), createdProduct.getName());
        assertEquals(addProduct.getBrand().getBrandId(), createdProduct.getBrand().getBrandId());
        verify(productRepository, times(1)).save(addProduct);
    }

    @Test
    public void testAddProduct_NotFoundCategory() {
        // Initialize categoryIds
        categoryIds = Arrays.asList(1L, 2L);
        categories = Arrays.asList();
        productDTO.setCategoryIds(categoryIds);

        // Mocking repository and mapper methods
        when(brandRepository.findById(productDTO.getBrandId())).thenReturn(Optional.of(brand));
        // Example of mocking category repository
        when(categoryRepository.findAllById(productDTO.getCategoryIds())).thenReturn(categories);
        when(productMapper.toEntity(productDTO)).thenReturn(addProduct);

        RuntimeException thrownException = assertThrows(RuntimeException.class, () -> {
            productService.addProduct(productDTO);
        });

        assertEquals("One or more categories not found", thrownException.getMessage());

        verify(productRepository, never()).save(any(Product.class));
    }

}
