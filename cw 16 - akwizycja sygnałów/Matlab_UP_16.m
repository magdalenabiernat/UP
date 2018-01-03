%-------------------------------------------------------------------
%       Urzadzenia Peryferyjne - Akwizycja sygnalow (16)
%       Pawel Szynal 226026
%       Lukasz Zatorski 226172
%-------------------------------------------------------------------

fileID = fopen('C:\Users\magda\Downloads','r');
formatSpec = '%f';
A = fscanf(fileID,formatSpec);
fclose(fileID);
%axis([0 100*32 -5 5]); %100 * 1024 - czas * probki
t= 0:0.001;2048;
figure(1);
plot(A);
ylabel('Amplituda');
xlabel('Czas [ms]');

