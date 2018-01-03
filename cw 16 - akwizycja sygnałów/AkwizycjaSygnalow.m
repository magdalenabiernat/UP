clear all;
%open the fire!
% file = fopen('Debugdane.txt');
% i = 1;
% counter = 0;
% t = 1:1:318;
%fid = fopen('Debugdane100.txt','r');
%data = fscanf(fid,'%f');
%fclose(fid);
data = textread('Debugdane100.txt','%f', 1, 2045,0);
subplot(2,2,1);
plot(data(1:2:end),data(2:2:end));
% if file > 0
%     while ~feof(file)
%         line = fgetl(file);
%         if counter == 0
%             macierz(i) = variable;
%             i = i + 1;
%         end
%         counter = counter + 1;
%         if counter == 3
%             counter = 0;
%         end
%     end
% end
% 
% figure
% subplot(3,1,1);
% plot(t, macierz);
% 
