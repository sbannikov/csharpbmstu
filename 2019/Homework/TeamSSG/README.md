![Alt text](architecture.jpg "�����������")

## SendService
�������� �� ���� REST WCF.
�������� ������ �� �� � ���������� �� ������ ������ � ������� XML.

���������:
1. getServiceUrl - URL �������, ���� ���������� �������� ������ � ��������. �������� �� ���������: http://localhost:7892

## TimerService
�������� �� ���� ConsoleApplication.
�� ������� �������� API-����� SendService.

���������: 
1. pollingInterval - ������� ������ ������� SendService � ������������. �������� �� ���������: 60000
2. sendServiceUrl - URL SendService. �������� �� ���������: http://localhost:30000

## GetService
�������� �� ���� REST WCF.
����������� ������. �������� ����������� ��� ������������.

�� ��������������.

## RenderService
�������� �� ���� ASP.NET MVC.
���������� ������������ ������ 5 ������ ���������� ���������� �� GetService.

���������:
1. getServiceUrl - URL ������� GetService. �������� �� ���������: http://localhost:7892