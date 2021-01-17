import discord
from keep_running import keep_alive
import os
from dotenv import load_dotenv
import random

load_dotenv()
token = os.getenv('DISCORD_TOKEN')


# .env 에서 토큰 관리

class MyClient(discord.Client):
    async def on_ready(self):
        print('\nLogged on as', self.user)
        # 디코 봇 온라인(로그인) 메세지

    async def on_message(self, message):
        if message.author == self.user:
            return

        # 해당 봇이 입력하는 메세지는 제외

        input_list = message.content.split(' ')
        factor = input_list[0]

        all_lane_eng = ['Top', 'Jug', 'Mid', 'Adc', 'Sup']
        all_lane_kor = ['탑', '정글', '미드', '원딜', '서폿']
        pick_error_eng = ['The fuck?', 'Not enough minerals', 'Play the god damn game u want']
        pick_error_kor = ['뭐 어쩌라는건데?', '답정너 야발아', '선택지를 늘려라 휴먼']
        lane_error_eng = ['Yo...', 'Go to the fucking school man', 'I can teach you math bro']
        lane_error_kor = ['숫자 못셈?', '안맞는다고', '초등학교는 나왔냐']

        async def num_to_lane(num_lane_list, factor):  # 숫자 라인 변경
            final_lane_list = []
            if factor == '!lane':
                for s in num_lane_list:
                    final_lane_list.append(all_lane_eng[int(s) - 1])
            else:
                for s in num_lane_list:
                    final_lane_list.append(all_lane_kor[int(s) - 1])
            return final_lane_list

        async def mix_merge_list(lane_list, person_list):  # 리스트 섞고서 병합
            random.shuffle(lane_list)
            random.shuffle(person_list)
            for s in range(len(lane_list)):
                await message.channel.send(person_list[s] + ' : ' + lane_list[s])

        if factor == '!help' or factor == '!도움':
            await message.channel.send('pick / 픽 [종목1],[종목2] \n: 종목1,종목2중 랜덤선택')
            await message.channel.send('lane / 라인 [라인숫자] [멘션1],[멘션2] \n: 각 사람당 라인 랜덤부여')

        elif factor == '!pick' or factor == '!픽':  # !pick [종목1],[종목2]
            event_list = message.content.split(' ', 1)[1].split(',')  # 종목 지정
            if len(event_list) == 1 and factor == '!pick':  # 종목 하나 영어
                await message.channel.send(random.choice(pick_error_eng))
            elif len(event_list) == 1:  # 종목 하나 한글
                await message.channel.send(random.choice(pick_error_kor))
            else:
                event_pick = random.choice(event_list)
                if factor == '!pick':  # 영어 선택
                    await message.channel.send(event_pick + ' gogo')
                else:  # 한글 선택
                    await message.channel.send(event_pick + ' ㄱㄱ')

        elif factor == '!lane' or factor == '!라인':
            lane_list = list(input_list[1])
            person_list = message.content.split(' ', 2)[2].split(' ')
            if len(lane_list) != len(person_list) and factor == '!lane':  # 갯수 불일치 영어
                await message.channel.send(random.choice(lane_error_eng))
            elif len(lane_list) != len(person_list):  # 갯수 불일치 한글
                await message.channel.send(random.choice(lane_error_kor))
            else:
                final_lane_list = await num_to_lane(lane_list, factor)
                await mix_merge_list(final_lane_list, person_list)


client = MyClient()  # ?
keep_alive()  # 서버 24시간 구동
client.run(token)  # 디코 토큰
