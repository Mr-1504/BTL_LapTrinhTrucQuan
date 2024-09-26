# BTL_LapTrinhTrucQuan
BeA Food ăn không ngon thì cút :))</br>
 Táo bán đồ ăn:))</br>
</br></br>

 ## Lưu ý
 >Form Size: 1600 x 900</br>

 >Nhiệm vụ của mỗi người sẽ được đưa ra trong Issues</br>
 >Không được push trực tiếp lên branch "main"</br>
 >Commit thường xuyên với các commit nhỏ
 >Mỗi ngày trước khi làm việc cần pull/rebase code từ main về để hạn chế conflict code
 >Ai làm nhiệm vụ gì thì tạo 1 branch với tên của nhiệm vụ đấy hoặc tạo trực tiếp từ issues đề ra.

**Hướng dẫn tạo branch từ Issues**</br>

- Bước 1: Mở Issues được giao</br>
![](https://drive.google.com/uc?export=view&id=1fztRlvER6tcHL95-RJ0yTG0rP6UxMdv3)</br>
- Bước 2: Mở Development, chọn create a branch</br>
![](https://drive.google.com/uc?export=view&id=1V-FvTnSiyO27_gcDzq9gA3dbs0APmfIk)
- Bước 3: Copy tên branch rồi tạo hoặc chọn create branch rồi làm theo hướng dẫn</br>
![](https://drive.google.com/uc?export=view&id=1V2zOH4RaK0S7tnxs9Fm1ZE_pEfOVjai6)



## Quy tắc đặt tên:
- Hằng số: viết in hoa, dùng dấu '_' giữa các từ</br>

  `private const int MAX_LENGTH = 2;`

- Interface: bắt đầu bằng chữ I in hoa</br>

   `public interface IUser`

- Biến private: dấu gạch dưới (_) trước tên của các biến private</br>

   `private int _totalAmount;`

- Tham số truyền vào: Tham số truyền vào method sử dụng camelCase.</br>

   `public void SaveOrder(int orderId, string customerName)`
 
- Tên Class sử dụng danh từ, viết hoa chữ cái đầu, cấu trúc Tên Class + Tên Layer</br>

   `public class UserBLL{}`

- Tên Method dùng động từ, viết hoa chữ cái đầu</br>

   `public void SaveOrder();`

- Tên Property, Enum đều viết hoa chữ cái đầu</br>

   ```
   public int TotalAmount {get => _totalAmount; set => _totalAmount = value;}
   public enum OrderStatus
   {
       Pending,
       Shipped,
       Delivered,
       Cancelled
   }
   ```
