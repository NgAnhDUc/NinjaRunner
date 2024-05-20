A - Đặt tên biến,hàm,hằng,đối tượng...
1.Tránh Magic numbers và đặt tên biến chỉ có một chữ cái
- Con số mà không có ý nghĩa rõ ràng 
	VD: số 60
	for (int i = 0; i < 60; i++) {
  	// do something
	}
- Đặt tên biến chỉ có một chữ cái
	VD: String q
2.Đặt tên có ý nghĩa
	VD: speed,damage,...
3.Đặt tên biến theo chuẩn Camel Case
-Tên phải bắt đầu bằng một chữ cái viết thường và tất cả các chữ cái đầu tiên của những từ tiếp theo sẽ được viết hoa
	VD: thisIsCamelCase
4.Đặt tên biến Boolean cụ thể hơn trong câu lệnh if-then
	VD: boolean isDead,isRun;
5.Sử dụng danh từ khi đặt tên class (lớp) ,object(đối tượng)
	VD:Player,Boss,Enemy
6.Sử dụng động từ khi đặt tên methol ,function
	VD: getDamage, shootingGun,...
7.Sử dụng các động từ nhất quán cho mỗi khái niệm
	VD: create, read, update, delete.
8.Viết hoa các hằng ,giá trị không đổi (Screaming Snake Case)
	VD: PI = 3.14;
	DAY_IN_A_YEAR = 365;
B -Khác
1.Tránh lặp code
	VD: Tránh sử dụng nhiều if-else (Dùng switch case)
2.Không phụ thuộc vào comments - comments vừa đủ ngắn gọn xúc tích
3.Tránh viết function quá dài - chia ra nhiều function đảm nhiệm 1 vai trò
4.Tránh dùng nhiều vòng lặp lồng nhau
5.Ưu tiên mô tả chi tiết hơn ngắn gọn
(trong trường hợp không chắc cách đặt tên ngắn gọn có thể hiện đủ ý nghĩa hay không)
	VD: DamageReceiverByEnemyInGround