namespace FetchWeather
{
    partial class WeatherForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnWeather = new System.Windows.Forms.Button();
            this.lblApiKey = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblTempF = new System.Windows.Forms.Label();
            this.lblTempFData = new System.Windows.Forms.Label();
            this.lblLocationData = new System.Windows.Forms.Label();
            this.lblCurrentLocation = new System.Windows.Forms.Label();
            this.lblFeelsLikeData = new System.Windows.Forms.Label();
            this.lblFeelsLike = new System.Windows.Forms.Label();
            this.lblHumidityData = new System.Windows.Forms.Label();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.lblWindSpeedData = new System.Windows.Forms.Label();
            this.lblWindSpeed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnWeather
            // 
            this.btnWeather.Location = new System.Drawing.Point(402, 457);
            this.btnWeather.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnWeather.Name = "btnWeather";
            this.btnWeather.Size = new System.Drawing.Size(171, 69);
            this.btnWeather.TabIndex = 0;
            this.btnWeather.Text = "Get Weather";
            this.btnWeather.UseVisualStyleBackColor = true;
            this.btnWeather.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblApiKey
            // 
            this.lblApiKey.AutoSize = true;
            this.lblApiKey.Location = new System.Drawing.Point(24, 32);
            this.lblApiKey.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblApiKey.Name = "lblApiKey";
            this.lblApiKey.Size = new System.Drawing.Size(189, 25);
            this.lblApiKey.TabIndex = 1;
            this.lblApiKey.Text = "weatherapi.com key:";
            // 
            // txtKey
            // 
            this.txtKey.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtKey.Location = new System.Drawing.Point(231, 28);
            this.txtKey.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(270, 29);
            this.txtKey.TabIndex = 2;
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLocation.Location = new System.Drawing.Point(231, 66);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(270, 29);
            this.txtLocation.TabIndex = 4;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(24, 70);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(85, 25);
            this.lblLocation.TabIndex = 3;
            this.lblLocation.Text = "Location";
            // 
            // lblTempF
            // 
            this.lblTempF.AutoSize = true;
            this.lblTempF.Location = new System.Drawing.Point(24, 185);
            this.lblTempF.Name = "lblTempF";
            this.lblTempF.Size = new System.Drawing.Size(133, 25);
            this.lblTempF.TabIndex = 5;
            this.lblTempF.Text = "Tempature (f):";
            // 
            // lblTempFData
            // 
            this.lblTempFData.AutoSize = true;
            this.lblTempFData.Location = new System.Drawing.Point(231, 185);
            this.lblTempFData.Name = "lblTempFData";
            this.lblTempFData.Size = new System.Drawing.Size(0, 25);
            this.lblTempFData.TabIndex = 6;
            // 
            // lblLocationData
            // 
            this.lblLocationData.AutoSize = true;
            this.lblLocationData.Location = new System.Drawing.Point(231, 160);
            this.lblLocationData.Name = "lblLocationData";
            this.lblLocationData.Size = new System.Drawing.Size(0, 25);
            this.lblLocationData.TabIndex = 8;
            // 
            // lblCurrentLocation
            // 
            this.lblCurrentLocation.AutoSize = true;
            this.lblCurrentLocation.Location = new System.Drawing.Point(24, 160);
            this.lblCurrentLocation.Name = "lblCurrentLocation";
            this.lblCurrentLocation.Size = new System.Drawing.Size(90, 25);
            this.lblCurrentLocation.TabIndex = 7;
            this.lblCurrentLocation.Text = "Location:";
            // 
            // lblFeelsLikeData
            // 
            this.lblFeelsLikeData.AutoSize = true;
            this.lblFeelsLikeData.Location = new System.Drawing.Point(231, 210);
            this.lblFeelsLikeData.Name = "lblFeelsLikeData";
            this.lblFeelsLikeData.Size = new System.Drawing.Size(0, 25);
            this.lblFeelsLikeData.TabIndex = 10;
            // 
            // lblFeelsLike
            // 
            this.lblFeelsLike.AutoSize = true;
            this.lblFeelsLike.Location = new System.Drawing.Point(24, 210);
            this.lblFeelsLike.Name = "lblFeelsLike";
            this.lblFeelsLike.Size = new System.Drawing.Size(124, 25);
            this.lblFeelsLike.TabIndex = 9;
            this.lblFeelsLike.Text = "Feels Like (f):";
            // 
            // lblHumidityData
            // 
            this.lblHumidityData.AutoSize = true;
            this.lblHumidityData.Location = new System.Drawing.Point(231, 235);
            this.lblHumidityData.Name = "lblHumidityData";
            this.lblHumidityData.Size = new System.Drawing.Size(0, 25);
            this.lblHumidityData.TabIndex = 12;
            // 
            // lblHumidity
            // 
            this.lblHumidity.AutoSize = true;
            this.lblHumidity.Location = new System.Drawing.Point(24, 235);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(97, 25);
            this.lblHumidity.TabIndex = 11;
            this.lblHumidity.Text = "Humidity:";
            // 
            // lblWindSpeedData
            // 
            this.lblWindSpeedData.AutoSize = true;
            this.lblWindSpeedData.Location = new System.Drawing.Point(231, 260);
            this.lblWindSpeedData.Name = "lblWindSpeedData";
            this.lblWindSpeedData.Size = new System.Drawing.Size(0, 25);
            this.lblWindSpeedData.TabIndex = 14;
            // 
            // lblWindSpeed
            // 
            this.lblWindSpeed.AutoSize = true;
            this.lblWindSpeed.Location = new System.Drawing.Point(24, 260);
            this.lblWindSpeed.Name = "lblWindSpeed";
            this.lblWindSpeed.Size = new System.Drawing.Size(119, 25);
            this.lblWindSpeed.TabIndex = 13;
            this.lblWindSpeed.Text = "Wind Speed:";
            // 
            // WeatherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 539);
            this.Controls.Add(this.lblWindSpeedData);
            this.Controls.Add(this.lblWindSpeed);
            this.Controls.Add(this.lblHumidityData);
            this.Controls.Add(this.lblHumidity);
            this.Controls.Add(this.lblFeelsLikeData);
            this.Controls.Add(this.lblFeelsLike);
            this.Controls.Add(this.lblLocationData);
            this.Controls.Add(this.lblCurrentLocation);
            this.Controls.Add(this.lblTempFData);
            this.Controls.Add(this.lblTempF);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.lblApiKey);
            this.Controls.Add(this.btnWeather);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "WeatherForm";
            this.Text = "Weather";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnWeather;
        private Label lblApiKey;
        private TextBox txtKey;
        private TextBox txtLocation;
        private Label lblLocation;
        private Label lblTempF;
        private Label lblTempFData;
        private Label lblLocationData;
        private Label lblCurrentLocation;
        private Label lblFeelsLikeData;
        private Label lblFeelsLike;
        private Label lblHumidityData;
        private Label lblHumidity;
        private Label lblWindSpeedData;
        private Label lblWindSpeed;
    }
}